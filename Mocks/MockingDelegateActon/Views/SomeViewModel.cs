using System.Collections.Generic;
using MockingDelegateActon.Models;
using MockingDelegateActon.Contracts;

namespace MockingDelegateActon.Views
{
    public class SomeViewModel
    {
        private readonly IMeetingRoomService _meetingRoomService;

        public List<MeetingRoom> Rooms { get; set; }

        public SomeViewModel(IMeetingRoomService meetingRoomService)
        {
            this._meetingRoomService = meetingRoomService;
        }

        public void GetRooms()
        {
            // Code that calls the service and sets this.Rooms
            _meetingRoomService.GetRooms(result => Rooms = result);
        }
    }
}