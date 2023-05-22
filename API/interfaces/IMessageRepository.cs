using API.Entities;
using API.Helpers;
using API.DTOs;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.interfaces
{
    public interface IMessageRepository
    {
        void AddMessage(Message message);
        void DeleteMessage(Message message);
        Task<Message> GetMessage(int id);
        Task<PagedList<MessageDto>> GetMessagesForUser(MessageParams messageParams);
        Task<IEnumerable<MessageDto>> GetMessageThread(string currentUserName, string recipientUsername);
        Task<bool> SaveAllAsync();
    }
}