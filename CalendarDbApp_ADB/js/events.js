// JavaScript source code
// Event class to contain the data for an event.
class Event {
    constructor(title, start, end = start) {
        this.id = numEvents;
        this.title = title;
        this.start = new Date(start);
        this.end = new Date(end);

        numEvents++
    }
}

// Logic to help create and manage events for display in this assignment.

var numEvents = 0;
var events = [
    new Event("Ash Wednesday", new Date(2018, 2, 14)),
    new Event("Valentine's Day", new Date(2018, 2, 14)),
    new Event("Valentine's Date :)", new Date(2018, 2, 15, 16, 30, 00), new Date(2018, 2, 15, 19, 00, 00)),
    new Event("Lakin's Baby Shower -- Yukon", new Date(2018, 2, 24, 10, 00, 00), new Date(2018, 2, 24, 13, 00, 00)),
    new Event("President's Day", new Date(2018, 2, 19)),
    new Event("Oklahoma Knights of Columbus State Bowling Tournament", new Date(2018, 2, 24), new Date(2018, 2, 25))
];

function getEvents(selectedDate = Date.now()) {
    return events.filter(e => (e.start.getFullYear() == selectedDate.getFullYear() && e.start.getMonth() == selectedDate.getMonth() &&
        e.start.getDate() == selectedDate.getDate()));
}

function showEvents(id = 0) {
    var cell = document.getElementById(id);
    if (cell.innerHTML.length > 2) {
        cell.innerHTML = id;
        return;
    }
    else {
        var newText = id + "<br /><br />";
        getEvents(new Date(2018, 2, id.valueOf())).forEach(function (e) {
            newText = newText + e.title + "<br />";
        });
        cell.innerHTML = newText;
    }
}