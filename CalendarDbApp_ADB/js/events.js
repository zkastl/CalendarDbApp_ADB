// JavaScript source code
var numTimesClicked = 0;

function generateTable() {
    var events = getEvents();
    var divElement = document.createElement('div');
    var tableHeaderDivElement = divElement.createElement('div');
    var body = document.getElementById("documentBody");
    body.appendChild(events);
}

function getEvents() {
    return [
        {
            name: "Zak's Birthday",
            event_date: 
        },
        new Event()
    ];
}

function showEvents() {
    numTimesClicked++;
}

class Event {
    constructor(id, title, start, end) {
        this.id = id;
        this.title = title;
        this.start = new Date(start);
        this.end = new Date(end);
    }
}

var testEvent = new Event(1, "test event", Date.now(), Date.now());
console.log(testEvent.start);