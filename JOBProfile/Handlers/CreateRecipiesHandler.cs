using JOBProfile.Commands;
using JOBProfile.Core.Repositories;
using JOBProfile.Mappers;
using JOBProfile.Responses;
using MediatR;

namespace JOBProfile.Handlers
{
    public class CreateRecipiesHandler: IRequestHandler<CreateRecipiesCommand, RecipiesResponse>
    {
        private readonly IRecipiesRepository _recipiesRepository;
        public CreateRecipiesHandler(IRecipiesRepository recipiesRepository)
        {
            _recipiesRepository = recipiesRepository;
        }

        public async Task<RecipiesResponse> Handle(CreateRecipiesCommand request, CancellationToken cancellationToken )
        {
            var recipyEntity = RecipyMapper.Mapper.Map<JOBProfile.Core.Entities.Recipies>(request);
            if (recipyEntity is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newRecipy = await _recipiesRepository.AddAsync(recipyEntity);
            var recipyResponse = RecipyMapper.Mapper.Map<RecipiesResponse>(newRecipy);
            return recipyResponse;
        }
    }
}
