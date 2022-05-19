using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace MauiBoilerplate.Core.Entities
{
    public class Song : FullAuditedEntity<long>
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override long Id { get; set; }

        public string MusicTitle { get; set; }

        public string Artist { get; set; }

        public string Album { get; set; }

        public TimeSpan Duration { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}
