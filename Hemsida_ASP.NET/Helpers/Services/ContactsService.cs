using Hemsida_ASP.NET.Helpers.Repos;
using Hemsida_ASP.NET.Models.Entities;
using Hemsida_ASP.NET.Models.ViewModels;
using System.Runtime.CompilerServices;

namespace Hemsida_ASP.NET.Helpers.Services
{
	public class ContactsService
	{
		private readonly ContactsRepo _contactsRepo;
		private readonly MessagesRepo _messagesRepo;

		public ContactsService(ContactsRepo contactsRepo, MessagesRepo messagesRepo)
		{
			_contactsRepo = contactsRepo;
			_messagesRepo = messagesRepo;
		}

		//Checks if a user has submitted a message via the form previously, if not- adds new user + the message, if they have- adds new message for the user
		public async Task AddOrUpdateContactAsync(ContactViewModel model)
		{
			var existingContact = await _contactsRepo.GetAsync(x => x.Email == model.Email);
			if ( existingContact == null)
			{
				ContactEntity entity = new ContactEntity
				{
					Name = model.Name,
					Email = model.Email,
					PhoneNumber = model.PhoneNumber,
					Company = model.Company,
					Messages = new List<ContactMessageEntity>
					{
						new ContactMessageEntity { Message = model.Message }
					}
				};

				await _contactsRepo.AddAsync(entity);
			}
			else
			{
				ContactMessageEntity messageEntity = new ContactMessageEntity
				{
					Message = model.Message,
					Contact = existingContact,
				};

				await _messagesRepo.AddAsync(messageEntity);
				existingContact.Messages.Add(messageEntity);
			}
		}
	}
}
