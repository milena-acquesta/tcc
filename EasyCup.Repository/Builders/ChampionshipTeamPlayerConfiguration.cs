using EasyCup.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCup.Repository.Builders
{


    public class ChampionshipTeamPlayerConfiguration : IEntityTypeConfiguration<ChampionshipTeamPlayer>
    {
        public void Configure(EntityTypeBuilder<ChampionshipTeamPlayer> builder)
        {
            builder.HasKey(k => k.ChampionshipID);
            builder.HasKey(k => k.TeamID);
            builder.HasKey(k => k.PlayerID);
        }
    }
}
