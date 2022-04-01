using AutoFixture;
using Moq;
using SEPUDO.Application.Contracts.Persistence;
using SEPUDO.Domain.Entidades;


namespace SEPUDO.Application.UnitTests.Mocks
{
    public static class MockSuscriptorRepository
    {
        public static Mock<ISuscriptorRepository> GetSuscriptorRepository()
        {
            var fixture = new Fixture();


            fixture.Behaviors.Add(new OmitOnRecursionBehavior());
            var suscriptores = fixture.CreateMany<Suscriptor>().ToList();
            suscriptores.Add(fixture.Build<Suscriptor>()
                .With(tr => tr.CreateBy, "lduarte")
                .Create()
                );

            var mockRepository = new Mock<ISuscriptorRepository>();
            mockRepository.Setup(r => r.GetAllAsync()).ReturnsAsync(suscriptores);

            return mockRepository;
        }
    }
}
