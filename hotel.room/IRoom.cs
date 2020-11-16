namespace projeto_hotel.hotel.room
{
    public interface IRoom
    {
        IRoom TypeRoom(string _typeRoom);

        IRoom DescriptionRoom(string _descriptRoom);
        
        IRoom ValueRoom(decimal _valueRoom);
        
    }
}