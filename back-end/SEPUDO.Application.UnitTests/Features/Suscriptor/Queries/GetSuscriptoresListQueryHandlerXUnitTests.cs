using AutoMapper;
using Moq;
using SEPUDO.Application.Contracts.Persistence;
using SEPUDO.Application.Features.Suscriptores.Queries.GetSuscriptoresList;
using SEPUDO.Application.Mappings;
using SEPUDO.Application.UnitTests.Mocks;
using Shouldly;
using Xunit;

namespace SEPUDO.Application.UnitTests.Features.Suscriptor.Queries
{
    public class GetSuscriptoresListQueryHandlerXUnitTests
    {
        private readonly IMapper mapper;
        private readonly Mock<IUnitOfWork> unitOfWork;

        public GetSuscriptoresListQueryHandlerXUnitTests()
        {
            unitOfWork = MockUnitOfWork.GetUnitOfWork();
            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });
            mapper = mapperConfig.CreateMapper();
        }

        [Fact]
        public async Task GetSuscriptorListTest()
        {
            var handler = new GetSuscriptoresListQueryHandler(unitOfWork.Object,mapper);
            var request = new GetSuscriptoresListQuery("lduarte");

            var result = await handler.Handle(request, CancellationToken.None);

            result.ShouldBeOfType<List<SuscriptoresVm>>();
        }
    }
}
