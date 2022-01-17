using MockingDelegateActon.Models;
using System;
using System.Collections.Generic;

namespace MockingDelegateActon.Contracts
{
    public interface IMeetingRoomService
    {
        void GetRooms(Action<List<MeetingRoom>> result);
    }
}
