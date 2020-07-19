using TDSBF;
namespace TDSBF.Data.Discord.Events.Protected.MessageEvents
{
    public static class OnMessageRecieved
    {
        private static MessageClasses.Message _Message { get; set; }
        public static MessageClasses.Message Message { get { return _Message; } set { _Message = value; TDSBF.Events.OnMessageRecieveFire(new MessageAlert(_Message)); } }
    }
}
