using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senhas
{
    public class CallCenter
    {
        private int _counter = 0;
        public Stack<IncomingCall>? Calls { get; set; }
        public CallCenter()
        {
            Calls = new Stack<IncomingCall>();
        }
        // Método para abertura de chamados
        public void Call(int clientId)
        {
            Calls!.Push(
            new IncomingCall()
            {
                Id = ++_counter,
                ClientId = clientId,
                CallTime = DateTime.Now
            }
            );
        }

        public IncomingCall Answer(string consultant)
        {
            if (Calls!.Count > 0)
            {
                IncomingCall call = Calls.Pop();
                call.Consultant = consultant;
                call.StartTime = DateTime.Now;

                return call;
            }
            return null!;
        }

        public void End(IncomingCall call)
        {
            call.EndTime = DateTime.Now;
        }

        public bool AreWaitingCalls()
        {
            return Calls!.Count > 0;
        }
    }
}