using static System.Console;
Ping pi=new Ping();
Pong po = new Pong();
PingPong pipo=new PingPong();
pipo.PingPongEvent += pi.PingPong;
pipo.PingPongEvent += po.PingPong;
while (true)
{
    pipo.go();
}
public delegate void PingPongDelegate();
class Ping
{
    public void PingPong()
    {
        WriteLine($"Ping received Pong");
    }
}
class Pong
{
    public void PingPong()
    {
        WriteLine($"Pong received Ping");
    }
}

class PingPong
{
    public event PingPongDelegate PingPongEvent;
    public void go()
    {
            if (PingPongEvent != null)
            {
                PingPongEvent();
                Thread.Sleep(1000);
                
            }

    }

}
