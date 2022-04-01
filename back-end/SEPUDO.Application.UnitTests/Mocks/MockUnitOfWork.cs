using Moq;
using SEPUDO.Application.Contracts.Persistence;


namespace SEPUDO.Application.UnitTests.Mocks
{
    public static class MockUnitOfWork
    {
        public static Mock<IUnitOfWork> GetUnitOfWork()
        {
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            var mockSuscriptorRepository = MockSuscriptorRepository.GetSuscriptorRepository();

            mockUnitOfWork.Setup(r => r.SuscriptorRepository).Returns(mockSuscriptorRepository.Object);

            return mockUnitOfWork;
        }
    }
}
