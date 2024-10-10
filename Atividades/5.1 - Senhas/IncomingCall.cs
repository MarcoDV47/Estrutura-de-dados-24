using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senhas
{

    // Esta classe representa a fila de chamados de um CallCenter
    public class IncomingCall
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CallTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Consultant { get; set; }
    }
}