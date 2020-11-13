using Application.ViewModels;
using AutoMapper;
using Domain;
using Domain.Interfaces;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Application.Test
{
    public class ValidateSubmissionTests
    {
        private readonly SubmissionService sut;
        private readonly Mock<ISubmissionRepository> mockRepo;
        private readonly Mock<IMapper> mockMapper;
        public ValidateSubmissionTests()
        {
            mockRepo = new Mock<ISubmissionRepository>();
            mockMapper = new Mock<IMapper>();
            sut = new SubmissionService(mockRepo.Object, mockMapper.Object);
        }
        [Fact]
        public async Task IsSubmissionValid()
        {
            //arrange
            var createSubmissionViewModel = new CreateSubmissionViewModel()
            {
                FirstName = "Thomas",
                SurName = "Petersen",
                Email = "thomasp@mail.dk",
                Age = 26,
                SerialNumber = 232145
            };
            var serialNumber = new SerialNumber()
            {
                Id = Guid.NewGuid().ToString(),
                SerialKey = 232145,
                TimesUsed = 0
            };
            var submission = new Submission()
            {
                FirstName = "Thomas",
                SurName = "Petersen",
                Email = "thomasp@mail.dk",
                Age = 26,
                SerialNumber = 232145
            };
            mockRepo.Setup(x => x.ValidSubmissionSerialNumber(createSubmissionViewModel.SerialNumber))
                .ReturnsAsync(serialNumber);
            mockMapper.Setup(x => x.Map<Submission>(createSubmissionViewModel)).Returns(submission);
            //act
            await sut.CreateSubmission(createSubmissionViewModel);

            //assert
            Assert.Equal(1, serialNumber.TimesUsed);
        }

        [Fact]
        public async Task Submission_IsInvalid_WithAgeUnder18()
        {
            //arrange
            var createSubmissionViewModel = new CreateSubmissionViewModel()
            {
                FirstName = "Rasmus",
                SurName = "Hansen",
                Email = "rasmushansen@mail.dk",
                Age = 15,
                SerialNumber = 234567
            };
            var serialNumber = new SerialNumber()
            {
                Id = Guid.NewGuid().ToString(),
                SerialKey = 234567,
                TimesUsed = 0
            };
            var submission = new Submission()
            {
                FirstName = "Rasmus",
                SurName = "Hansen",
                Email = "rasmushansen@mail.dk",
                Age = 15,
                SerialNumber = 234567
            };
            mockRepo.Setup(x => x.ValidSubmissionSerialNumber(createSubmissionViewModel.SerialNumber))
                .ReturnsAsync(serialNumber);
            mockMapper.Setup(x => x.Map<Submission>(createSubmissionViewModel)).Returns(submission);
            //act
            await sut.CreateSubmission(createSubmissionViewModel);
            //assert
            Assert.Equal(0, serialNumber.TimesUsed);
        }
        [Fact]
        public async Task Submission_IsInvalid_WithTwoTimesUsedSerialnumber()
        {
            //arrange
            var createSubmissionViewModel = new CreateSubmissionViewModel()
            {
                FirstName = "Rasmus",
                SurName = "Hansen",
                Email = "rasmushansen@mail.dk",
                Age = 20,
                SerialNumber = 234567
            };
            var serialNumber = new SerialNumber()
            {
                Id = Guid.NewGuid().ToString(),
                SerialKey = 234567,
                TimesUsed = 2
            };
            var submission = new Submission()
            {
                FirstName = "Rasmus",
                SurName = "Hansen",
                Email = "rasmushansen@mail.dk",
                Age = 20,
                SerialNumber = 234567
            };
            mockRepo.Setup(x => x.ValidSubmissionSerialNumber(createSubmissionViewModel.SerialNumber))
                .ReturnsAsync(serialNumber);
            mockMapper.Setup(x => x.Map<Submission>(createSubmissionViewModel)).Returns(submission);
            //act
            await sut.CreateSubmission(createSubmissionViewModel);
            //assert
            Assert.Equal(2, serialNumber.TimesUsed);
        }
    }
}
