using JOBProfile.Responses;
using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace JOBProfile.Commands
{
    public class CreateRecipiesCommand: IRequest<RecipiesResponse>
    {
        public List<string> Ingredients { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CookingInstructions { get; set; }
    }
}
