
namespace projeto_hotel.hotel.room.Double
{
    public class DoubleBuilder : IRoom
    {
        private DoubleRoom _doubleRoom;

        public DoubleBuilder()
        {
            _doubleRoom = new DoubleRoom();
        }

        public IRoom DescriptionRoom(string _descriptRoom)
        {
            _doubleRoom.DescriptionRoom = _descriptRoom;
            return this;
        }

        public IRoom TypeRoom(string _typeRoom)
        {
            _doubleRoom.TypeRoom = _typeRoom;
            return this;
        }

        public IRoom ValueRoom(decimal _valueRoom)
        {
            _doubleRoom.ValueRoom = _valueRoom;
            return this;
        }

        public DoubleRoom Build()
        {
            return this._doubleRoom;
        }
    }
}