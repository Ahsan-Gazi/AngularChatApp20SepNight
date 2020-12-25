$(function () {
    var chatHub = $.connection.chatHub;
    chatHub.client.broadcast = function (name, message) {
        var myName = $('<div/>').text(name).html();
        var myMessage = $('<div/>').text(message).html();
        $('#discussion').append('<li><strong>' + myName + ':</strong> &nbsp;&nbsp; ' + myMessage + '</li>');
        $('#message').val("");
    }
    $('#displayName').val(prompt('Enter your Name', 'Gazi'));
    $('#message').focus();

    $.connection.hub.start().done(function () {
        $('#sendMessage').click(function () {
            chatHub.server.send($('#displayName').val(), $('#message').val() + '\n')
        })
    });
})