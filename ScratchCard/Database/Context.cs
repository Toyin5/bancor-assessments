

using Microsoft.EntityFrameworkCore;
using ScratchCard.Models;

namespace ScratchCard.Database
{
    public class Context : DbContext
    {
        public DbSet<Card> Cards { get; set; }
    }
}
