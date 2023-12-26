using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using Proiect.Models;

namespace Proiect.Data
{
    public class TicketListDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public TicketListDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Ticket>().Wait();
        }
        public Task<List<Ticket>> GetTicketAsync()
        {
            return _database.Table<Ticket>().ToListAsync();
        }
        public Task<Ticket> GetTicketAsync(int id)
        {
            return _database.Table<Ticket>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveTicketAsync(Ticket tlist)
        {
            if (tlist.ID != 0)
            {
                return _database.UpdateAsync(tlist);
            }
            else
            {
                return _database.InsertAsync(tlist);
            }
        }
        public Task<int> DeleteTicketAsync(Ticket tlist)
        {
            return _database.DeleteAsync(tlist);
        }
    }
}
