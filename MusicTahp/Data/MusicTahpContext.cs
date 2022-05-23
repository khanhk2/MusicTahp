using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicTahp.Models;

namespace MusicTahp.Data
{
    public class MusicTahpContext : DbContext
    {
        public MusicTahpContext (DbContextOptions<MusicTahpContext> options)
            : base(options)
        {
        }

        public DbSet<MusicTahp.Models.Music> Music { get; set; }
    }
}
