using raft.models;
using Spectre.Console;

namespace raft.components;

public class CompFuelLogEvent {
    private CalendarEvent? calendarEvent;
    private FuelLogEntry? entry;

    public CompFuelLogEvent CreateFuelLogEvent(FuelLogEntry fuleLogEntry, DateTime time) {
        entry = fuleLogEntry;
        calendarEvent = new CalendarEvent(time.Year, time.Month, time.Day);
        return this;
    }
}