
$(document).ready(function(){
    // Requisicao para a API
    $.ajax({
        type:'GET',
        contentType:"application/json; charset=uft-8",
        dataType:'json',
        url: "https://localhost:5001/Aninhados/DataAninhados",
        error: function ()
        {
            alert("Ocorreu um erro ao consultar os dados!")
        },
        success: function(data){
            console.log(data);
            GraficoLacosAninhados(data);
        }
    })
})


function GraficoLacosAninhados(data)
{

    var colors = Highcharts.getOptions().colors;

    Highcharts.chart('container', {
        chart: {
            type: 'spline'
        },

        legend: {
            symbolWidth: 40
        },

        title: {
            text: 'Análise de Complexidade em Função do Tempo'
        },

        subtitle: {
            text: 'Comportamento: Laços aninhados'
        },

        yAxis: {
            title: {
                text: 'Tempo (ms)'
            },
            accessibility: {
                description: 'Tempo (ms)'
            }
        },

        xAxis: {
            title: {
                text: 'nº entradas'
            },
            accessibility: {
                description: 'Time from December 2010 to September 2019'
            },
            categories: [1, 2, 3, 4, 5, 6]
        },

        tooltip: {
            valueSuffix: '%'
        },

        plotOptions: {
            series: {
                point: {
                    events: {
                        click: function () {
                            window.location.href = this.series.options.website;
                        }
                    }
                },
                cursor: 'pointer'
            }
        },

        series: data,

        responsive: {
            rules: [{
                condition: {
                    maxWidth: 550
                },
                chartOptions: {
                    chart: {
                        spacingLeft: 3,
                        spacingRight: 3
                    },
                    legend: {
                        itemWidth: 150
                    },
                    xAxis: {
                        categories: [1, 2, 3, 4, 5, 6],
                        title: 'ASDASDASDASDAS'
                    },
                    yAxis: {
                        visible: false
                    }
                }
            }]
        }
    });
}