﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MediatR;
using Moq;
using NUnit.Framework;
using Sfa.Das.Sas.ApplicationServices.Queries;
using Sfa.Das.Sas.ApplicationServices.Responses;
using Sfa.Das.Sas.Core.Domain;
using Sfa.Das.Sas.Core.Domain.Model;
using Sfa.Das.Sas.Shared.Components.Mapping;
using Sfa.Das.Sas.Shared.Components.Orchestrators;
using Sfa.Das.Sas.Shared.Components.ViewComponents.ApprenticeshipDetails;
using SFA.DAS.NLog.Logger;

namespace Sfa.Das.Sas.Shared.Components.UnitTests.Orchestrator
{
    [TestFixture]
    public class ApprenticeshipOrchestratorTests
    {
        private Mock<IMediator> _mediatorMock;
        private Mock<ILog> _loggerMock;
        private Mock<IFrameworkDetailsViewModelMapper> _frameworkMapperMock;
        private Mock<IStandardDetailsViewModelMapper> _standardMapperMock;
        private ApprenticeshipOrchestrator _sut;
        private string _frameworkId = "420-2-1";

        private FrameworkDetailsViewModel _framework = new FrameworkDetailsViewModel();
        private StandardDetailsViewModel _standard = new StandardDetailsViewModel();

        [SetUp]
        public void Setup()
        {
            _mediatorMock = new Mock<IMediator>(MockBehavior.Strict);
            _loggerMock = new Mock<ILog>();
            _frameworkMapperMock = new Mock<IFrameworkDetailsViewModelMapper>(MockBehavior.Strict);
            _standardMapperMock = new Mock<IStandardDetailsViewModelMapper>(MockBehavior.Strict);


            _mediatorMock.Setup(s => s.Send<GetFrameworkResponse>(It.Is<GetFrameworkQuery>(request => request.Id == "420-2-1"), It.IsAny<CancellationToken>())).ReturnsAsync(new GetFrameworkResponse() { StatusCode = GetFrameworkResponse.ResponseCodes.InvalidFrameworkId });
            _mediatorMock.Setup(s => s.Send<GetFrameworkResponse>(It.Is<GetFrameworkQuery>(request => request.Id == "530-2-1"), It.IsAny<CancellationToken>())).ReturnsAsync(new GetFrameworkResponse() { StatusCode = GetFrameworkResponse.ResponseCodes.FrameworkNotFound });
            _mediatorMock.Setup(s => s.Send<GetFrameworkResponse>(It.Is<GetFrameworkQuery>(request => request.Id == "130-2-1"), It.IsAny<CancellationToken>())).ReturnsAsync(new GetFrameworkResponse() { StatusCode = GetFrameworkResponse.ResponseCodes.Gone });
            _mediatorMock.Setup(s => s.Send<GetFrameworkResponse>(It.Is<GetFrameworkQuery>(request => request.Id == "230-2-1"), It.IsAny<CancellationToken>())).ReturnsAsync(new GetFrameworkResponse() { StatusCode = GetFrameworkResponse.ResponseCodes.Success, Framework = new Framework(){ FrameworkId = "230-2-1"}});

            _mediatorMock.Setup(s => s.Send(It.Is<GetStandardQuery>(request => request.Id == "678"), It.IsAny<CancellationToken>())).ReturnsAsync(new GetStandardResponse() { StatusCode = GetStandardResponse.ResponseCodes.HttpRequestException });
            _mediatorMock.Setup(s => s.Send(It.Is<GetStandardQuery>(request => request.Id == "567"), It.IsAny<CancellationToken>())).ReturnsAsync(new GetStandardResponse() { StatusCode = GetStandardResponse.ResponseCodes.InvalidStandardId });
            _mediatorMock.Setup(s => s.Send(It.Is<GetStandardQuery>(request => request.Id == "456"), It.IsAny<CancellationToken>())).ReturnsAsync(new GetStandardResponse() { StatusCode = GetStandardResponse.ResponseCodes.StandardNotFound });
            _mediatorMock.Setup(s => s.Send(It.Is<GetStandardQuery>(request => request.Id == "345"), It.IsAny<CancellationToken>())).ReturnsAsync(new GetStandardResponse() { StatusCode = GetStandardResponse.ResponseCodes.AssessmentOrgsEntityNotFound, Standard = new Standard() { StandardId = "345" } });
            _mediatorMock.Setup(s => s.Send(It.Is<GetStandardQuery>(request => request.Id == "234"), It.IsAny<CancellationToken>())).ReturnsAsync(new GetStandardResponse() { StatusCode = GetStandardResponse.ResponseCodes.Gone });
            _mediatorMock.Setup(s => s.Send(It.Is<GetStandardQuery>(request => request.Id == "123"), It.IsAny<CancellationToken>())).ReturnsAsync(new GetStandardResponse() { StatusCode = GetStandardResponse.ResponseCodes.Success, Standard = new Standard() { StandardId = "123" } });



            _frameworkMapperMock.Setup(s => s.Map(It.IsAny<Framework>())).Returns(_framework);
            _standardMapperMock.Setup(s => s.Map(It.IsAny<Standard>(), It.IsAny<IList<AssessmentOrganisation>>())).Returns(_standard);

            _sut = new ApprenticeshipOrchestrator(_mediatorMock.Object, _loggerMock.Object, _frameworkMapperMock.Object,_standardMapperMock.Object);
        }

        #region FrameworkTests
        [Test]
        public async Task When_Getting_Framework_And_Response_StatusCode_Is_InvalidFrameworkId_Then_Exception()
        {

            Action result = () => _sut.GetFramework(_frameworkId).Wait();

           result.Should().Throw<ArgumentException>()
               .WithMessage("Framework id: 420-2-1 has wrong format");
        }

        [Test]
        public async Task When_Getting_Framework_And_Response_StatusCode_Is_FrameworkNotFound_Then_Exception()
        {

            Action result = () => _sut.GetFramework("530-2-1").Wait();

            result.Should().Throw<ArgumentException>()
                .WithMessage("Cannot find framework: 530-2-1");
        }
        [Test]
        public async Task When_Getting_Framework_And_Response_StatusCode_Is_Gone_Then_Exception()
        {

            Action result = () => _sut.GetFramework("130-2-1").Wait();

            result.Should().Throw<ArgumentException>()
                .WithMessage("Expired framework request: 130-2-1");
        }

        [Test]
        public async Task When_Getting_Framework_And_Response_StatusCode_Is_Success_Then_Return_Viewmodel()
        {

            var result = await _sut.GetFramework("230-2-1");

            result.Should().BeOfType<FrameworkDetailsViewModel>();
        }

        [Test]
        public async Task When_Getting_Framework_And_Response_StatusCode_Is_Success_Then_Map_Results()
        {

            var result = await _sut.GetFramework("230-2-1");

            _frameworkMapperMock.Verify(v => v.Map(It.IsAny<Framework>()),Times.Once);
        }
        #endregion

        #region StandardTests
        [Test]
        public async Task When_Getting_Standard_And_Response_StatusCode_Is_HttpRequestException_Then_Exception()
        {

            Action result = () => _sut.GetStandard("678").Wait();

            result.Should().Throw<Exception>()
                .WithMessage("Request error when requesting assessment orgs for standard: 678");
        }
        [Test]
        public async Task When_Getting_Standard_And_Response_StatusCode_Is_InvalidStandardId_Then_Exception()
        {

            Action result = () => _sut.GetStandard("567").Wait();

            result.Should().Throw<Exception>()
                .WithMessage("Cannot find any standards with an ID below zero");
        }

        [Test]
        public async Task When_Getting_Standard_And_Response_StatusCode_Is_StandardNotFound_Then_Exception()
        {

            Action result = () => _sut.GetStandard("456").Wait();

            result.Should().Throw<Exception>()
                .WithMessage("Cannot find standard: 456");
        }
        [Test]
        public async Task When_Getting_Standard_And_Response_StatusCode_Is_AssessmentOrgNotFound_Then_Return_ViewModel()
        {

            var result = await _sut.GetStandard("345");

            result.Should().BeOfType<StandardDetailsViewModel>();
            result.Should().NotBeNull();
        }
        [Test]
        public async Task When_Getting_Standard_And_Response_StatusCode_Is_Gone_Then_Exception()
        {

            Action result = () => _sut.GetStandard("234").Wait();

            result.Should().Throw<Exception>()
                .WithMessage("Expired standard request: 234");
        }

        [Test]
        public async Task When_Getting_Standard_And_Response_StatusCode_Is_Success_Then_Return_Viewmodel()
        {

            var result = await _sut.GetStandard("123");

            result.Should().BeOfType<StandardDetailsViewModel>();
            result.Should().NotBeNull();
        }

        [Test]
        public async Task When_Getting_Standard_And_Response_StatusCode_Is_Success_Then_Map_Results()
        {

            var result = await _sut.GetStandard("123");

            _standardMapperMock.Verify(v => v.Map(It.IsAny<Standard>(),It.IsAny<IList<AssessmentOrganisation>>()), Times.Once);
        }
        #endregion
    }
}