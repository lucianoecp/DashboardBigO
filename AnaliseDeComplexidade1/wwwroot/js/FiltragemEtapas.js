$(document).ready(function () {
    // Requisição
    $.ajax({
        type: "GET",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        url: urlBase + '/DataFiltragemEtapas',
        error: function () {
            alert("Ocorreu um erro ao acessar os dados em " + url);
        },
        success: function (data) {
            GraficoFiltragemEtapas(data);
        }
    })
});

function GraficoFiltragemEtapas(data) {
    Highcharts.chart('FiltragemEtapas', {
        chart: {
            type: 'line'
        },
        title: {
            text: 'Analise de Complexidade em função da quantidade de instruções relevantes'
        },
        subtitle: {
            text: 'Time 06 - EDA'
        },
        xAxis: {
            categories: [
                15.0,
                150.0,
                285.0,
                420.0,
                555.0,
                690.0,
                825.0,
                960.0,
                1095.0,
                1230.0,
                1365.0,
                1500.0],
            title: {
                text: 'nº de entradas'
            }

        },
        yAxis: {
            title: {
                text: 'instruções relevantes'
            }
        },
        plotOptions: {
            line: {
                dataLabels: {
                    enabled: true
                },
                enableMouseTracking: false
            }
        },
        series: data
    });
}