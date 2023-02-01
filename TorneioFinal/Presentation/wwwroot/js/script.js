

//document.addEventListener('click', callback)
//function callback() {
//	console.log('clicou');
//}

//let cardsJogadores = document.querySelectorAll('.card-inteiro');
//console.log(cardsJogadores);

//cardsJogadores.forEach((card) => {
//	card.addEventListener('click', AtivaClasseSelecionados);
//	console.log(card);
//});


//function AtivaClasseSelecionados(event) {
//	let quantidadeSelecionada = document.querySelectorAll('.selecionado').length
//	if (quantidadeSelecionada < 4) {

//		event.currentTarget.classList.toggle('selecionado');

//		console.log(quantidadeSelecionada);
//	}
//	else {
//		alert('Número máximo excedido');
//	}
//};

///* const botaoIniciaTorneio = document.querySelectorAll('.botaoIniciaTorneio');
//console.log(botaoIniciaTorneio); */
//let botaoIniciaTorneio = document.getElementById("botaoIniciaTorneio");
//console.log(botaoIniciaTorneio);
//botaoIniciaTorneio.addEventListener('click', EnviaParticipantes);

//function EnviaParticipantes() {

//	let quantidadeSelecionada = document.querySelectorAll('.selecionado').length;
//	console.log(quantidadeSelecionada);
//	if (quantidadeSelecionada != 4) {
//		alert('Você não selecionou os 4 participantes');
//	}
//	else {
//		let jogadoresSelecionados = document.querySelectorAll('.selecionado');
//		let jogadoresSelecionadosArray = Array.from(jogadoresSelecionados);
//		console.log(jogadoresSelecionadosArray);
//	}
//};

var cardsSelecionados = [];

function selecionarCard(id) {
    const card = $(`#card-${id}`);
    card.toggleClass('selecionado');
    if (card.hasClass('selecionado')) {
        cardsSelecionados.push(id);
    }
    else {
        const index = cardsSelecionados.indexOf(id);

        const x = cardsSelecionados.splice(index, 1);
    }
    console.log(cardsSelecionados);
}



function enviarSelecionar() {
    const url = $('#UrlMetodoParaChamar').val() ;
    console.log(cardsSelecionados);
    let quantidadeSelecionada = document.querySelectorAll('.selecionado');
    

    $.ajax({
        type: 'POST',
        url: url,
        data: { "ids": cardsSelecionados },
        dataType: "json",
        Traditional: true,
        //contentType: 'application/json; charset=utf-8',

    });



};

//return $.ajax({
//    type: 'POST',
//    url: "Torneio/RealizarTorneio",
//    contentType: 'application/json',
//    data: JSON.stringify(lutadoresSelecionados.toString()),
//    success: function (result) {
//        if (result.isCreated) {
//            setTimeout(function () {
//                hiddenLoad();
//                window.location = result.url;
//            }, 27500);
//        }
//        else {
//            showAlert(result.Message);
//        }
//    },
//    error: function (error) {
//        hiddenLoad();
//        showAlert("Erro ao realizar torneio");
//        console.error("Error:" + JSON.stringify(error.responseJSON.errorMessage));
//    }
//});

