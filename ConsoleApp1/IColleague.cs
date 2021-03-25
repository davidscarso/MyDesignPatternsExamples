namespace ConsoleApp1
{
    public abstract class IColleague
    {
        private IMediator mediador;
 
        public IMediator Mediator 
        {
            get; 
        }

        protected IColleague(IMediator mediador)
        {
            this.mediador = mediador;            
        }

        public void Communicate(string message) 
        {
            this.mediador.Send(message, this);
        }

       public abstract void Receive( string message);
    }
}