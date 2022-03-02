
(function (window) {
    'use strict';
    var app = function () {
        var Calendar = function () {

            this.PrevNextButton = function () {
                $(document).on('click', ".month", function () {
                    var object = $(this).attr("id");
                    var month = object.split('/')[0];
                    var year = object.split('/')[1];
                    $.ajax({
                        url: '/Home/UpdateCalendar',
                        contentType: 'application/html; charset=utf-8',
                        type: 'GET',
                        dataType: 'html',
                        data: { month: month, year: year },
                        success: function (result) {
                            $(".divCalendar").html(result);
                        }
                    });
                });
            };

            this.Mouseover = function () {
                $(document).on('mouseover', "td", function () {
                    if ($(this).hasClass("calendar-remove-hover")) {
                        $(this).addClass("calendar-hover");
                        $(this).removeClass("calendar-remove-hover");
                    }
                });
            };

            this.Mouseleave = function () {
                $(document).on('mouseleave', "td", function () {
                    if ($(this).hasClass("calendar-hover")) {
                        $(this).addClass("calendar-remove-hover");
                        $(this).removeClass("calendar-hover");
                    }
                });
            };
        }
        return Calendar;
    }
    if (typeof (Calendar) === 'undefined') {
        window.Calendar = app();
    } else {
        console.log("Library already defined.");
    }
})(window);