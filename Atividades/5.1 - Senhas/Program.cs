// Uma fila é a estrutura de dados que pode ser aplicada
// para representar a fila de atendimento da cantina
// As pessoas que chegam, entram no final da fila
// e as primeiras que chegaram são atendidas primeiro.

// A função ENQUEUE é responsável por adicionar novos elementos
// à fila

// A função DEQUEUE é responsável por remover elementos da fila.

// Desta forma, obedece o princípio do FIFO
// (First In First Out)

using Senhas;

Random random = new();

CallCenter center = new();
center.Call(1234);
center.Call(1369);
center.Call(2468);
center.Call(1478);

while (center.AreWaitingCalls())
{
    Thread.Sleep(3000);
    IncomingCall call = center.Answer("Thiago");
    Console.WriteLine(
        @$"
        {DateTime.Now:HH:mm:ss}
        Senha: #{call.Id}"
    );
    Thread.Sleep(random.Next(1000, 10000));
    center.End(call);
    Console.WriteLine(
        @$"
        Senha: {call.Id}
        Encerrado às: {call.EndTime}"
    );
}