using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message2TrashBin
    {
        [Key]
        public int Message_ID { get; set; }
        public int? Message_Sender { get; set; }
        public int? Message_Receiver { get; set; }
        public string Message_Context { get; set; }
        public string Message_Title { get; set; }
        public DateTime Date { get; set; }
        public Writer SenderUser { get; set; }
        public Writer ReceiverUser { get; set; }
        public string Type { get; set; }
    }
}
