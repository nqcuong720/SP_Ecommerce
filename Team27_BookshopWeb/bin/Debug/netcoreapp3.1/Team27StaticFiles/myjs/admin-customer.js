﻿$(document).ready(function () {
    $.ajax({
        url: '/admin/ThongKe/CustomerChart',
        data: {
            day: $("select#day").val()
        },
        dataType: "json",
        type: "GET",
        contentType: "application/json",

        success: function (result) {
            google.charts.load('current', {
                'packages': ['corechart']
            });
            google.charts.setOnLoadCallback(function () {
                drawChart(result);
            });
        }
    });
    function drawChart(result) {
        var data = new google.visualization.DataTable();
        data.addColumn('string', 'Ngày đăng ký');
        data.addColumn('number', 'Số lượng khách hàng');
        var dataArray = [];
        $.each(result, function (i, obj) {
            dataArray.push([obj.displayDate, parseInt(obj.count)]);
        });

        data.addRows(dataArray);

        var piechart_options = {
            title: 'Biểu đồ cột hiển thị số lượng khách hàng',
            width: 600,
            height: 400
        };
        var piechart = new google.visualization.BarChart(document.getElementById('piechart_div'));
        piechart.draw(data, piechart_options);
    }
});

