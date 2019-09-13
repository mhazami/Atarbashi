using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Atarbashi.DataStructure.Tools.Enums;

namespace Atarbashi.DataStructure
{
    [Table("Message", Schema = "Message")]
    public class Message
    {
        [Key]
        public Guid Id { get; set; }

        public MessageType Type { get; set; }

        public string Cc { get; set; }

        public string Subject { get; set; }

        public string Text { get; set; }
    }
}
