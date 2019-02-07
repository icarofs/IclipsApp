$(document).ready(function () {

    $(".botaogeral").click(function () {
        $(".titulo-pagina span").html("Ordenado");
    });

    $('#DivGeral').css('display', 'initial');

    $('#link-em-andamento').on('click', function () {
        $('#DivGeral').css('display', 'none');
        $('#DivAtrasados').css('display', 'none');
        $('#DivEmAndamento').css('display', 'initial');   
        $('#DivPessoasOrdenadas').css('display', 'none');
    })

    $('#link-atrasadas').on('click', function () {
        $('#DivGeral').css('display', 'none');
        $('#DivAtrasados').css('display', 'initial');
        $('#DivEmAndamento').css('display', 'none');
        $('#DivPessoasOrdenadas').css('display', 'none');
    })

    $('#link-atrasadas').on('click', function () {
        $('#DivGeral').css('display', 'none');
        $('#DivAtrasados').css('display', 'initial');
        $('#DivEmAndamento').css('display', 'none');
        $('#DivPessoasOrdenadas').css('display', 'none');
    })
    
    $('.botaogeral').on('click', function () {
        $('#DivGeral').css('display', 'none');
        $('#DivAtrasados').css('display', 'none');
        $('#DivEmAndamento').css('display', 'none');
        $('#DivPessoasOrdenadas').css('display', 'initial');
    });

    init();
    function init() {

        $("#link-em-andamento").click(function () {
            $(".titulo-pagina span").html($(this).find("span").html());
            $(this).addClass('active').siblings().removeClass('active');

        });
        $("#link-atrasadas").click(function () {
            $(".titulo-pagina span").html($(this).find("span").html());
            $(this).addClass('active').siblings().removeClass('active');
        });


     
    }
});