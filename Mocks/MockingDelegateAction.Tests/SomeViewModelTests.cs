using Moq;
using System;
using NUnit.Framework;
using MockingDelegateActon.Views;
using System.Collections.Generic;
using MockingDelegateActon.Models;
using MockingDelegateActon.Contracts;

namespace MockingDelegateActon.Tests.NUnitTests
{
    
    [TestFixture]
    public class SomeViewModelTests
    {

        [Test]
        public void GetRooms_ShouldSetRooms()
        {
            // Arrange
            var meetingRoomServiceMock = new Mock<IMeetingRoomService>();
            
            var someViewModelUnderTests = new SomeViewModel(meetingRoomServiceMock.Object);

            var expectedRoomList = new List<MeetingRoom>
                                    {
                                        new MeetingRoom(999, "FirstTestRoom"),
                                        new MeetingRoom(555, "SecondTestRoom"),
                                    };

            meetingRoomServiceMock
                .Setup(service => service.GetRooms(It.IsAny<Action<List<MeetingRoom>>>()))
                .Callback((Action<List<MeetingRoom>> action) => action(expectedRoomList));
            
            // Act
            someViewModelUnderTests.GetRooms();
            
            // Assert
            Assert.AreEqual(expectedRoomList, someViewModelUnderTests.Rooms);
        }
    }
}