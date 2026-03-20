Oqtane = Oqtane || {};
Oqtane.Theme = Oqtane.Theme || {};
Oqtane.Theme.Massively = Oqtane.Theme.Massively || {};

Oqtane.Theme.Massively.load = function () {
    // Re-initialize Massively theme after Blazor navigation
    var $body = $('body');
    $body.addClass('is-preload');
    window.setTimeout(function () {
        $body.removeClass('is-preload');
    }, 100);
};
