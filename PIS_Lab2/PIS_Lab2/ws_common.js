let ws = null;
let ta = document.getElementById('ta');
let bstart;
let bstop;




window.onload = function () {
    bstart = document.getElementById('bstart');
    bstop = document.getElementById('bstop');

    if (Modernizr.websockets) {
        WriteMessage('support', 'Да.');
    }
    else {
        WriteMessage('support', 'Нет.');
    }
}


function exe_start() {
    if (ws == null) {
        ws = new WebSocket('ws://localhost:3333/ws');     // Dont't forget to change port!
        ws.onopen = function () { ws.send('Connection'); }
        ws.onclose = function (msg) { console.log('onclose: ', msg); }
        ws.onmessage = function (msg) { ta.innerHTML += '\n' + msg.data; }
        bstart.disabled = true;
        bstop.disabled = false;
    }
}


function exe_stop() {
    ws.close(3001, 'stopWebSocket');
    ws = null;
    bstart.disabled = false;
    bstop.disabled = true;
}




function WriteMessage(elementIid, message) {
    let span = document.getElementById(elementIid);
    span.innerHTML = message;
}