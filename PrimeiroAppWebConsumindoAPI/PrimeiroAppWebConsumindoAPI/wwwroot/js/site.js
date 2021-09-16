// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.




// Write your JavaScript code.
/*

let formAleterar = document.getElementsByName("FormAlterar")[0];

let nome = document.getElementsByName("Nome")[0];
let produtora = document.getElementsByName("Produtora")[0];
let preco = document.getElementsByName("Preco")[0];

//Array de parametros 'chave=valor'
var params = window.location.search.substring(1).split('&');

//Criar objeto que vai conter os parametros
var paramArray = {};

//Passar por todos os parametros
for (var i = 0; i < params.length; i++) {
    //Dividir os parametros chave e valor
    var param = params[i].split('=');

    //Adicionar ao objeto criado antes
    paramArray[param[0]] = param[1];
}

let id = paramArray["id"] || "";


console.log(formAleterar);
console.log(id);

let url = `https://localhost:44354/api/v1/Jogos/${id}`;

console.log(url);

formAleterar.onsubmit = function (event) {
    event.preventDefault();
    let pass = true;
   

    if (nome.value === "") {
        pass = false;
        
    }
    if (produtora.value === "") {

        pass = false;
    }
    if (preco.value === "") {

        pass = false;

    }
    if (!pass) {
        
        return;
    }

    jogo = {
        Nome : nome.value,
        Produtora : produtora.value,
        Preco : preco.value
    }

    

    console.log(jogo);
    makeRequest(url, jogo);
    

};

function  makeRequest(url, jogo) {

    let httpRequest = new XMLHttpRequest();

    //httpRequest.onreadystatechange = alertContents;
    httpRequest.open('PUT', url);
    httpRequest.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    console.log(httpRequest);
     httpRequest.send({
        'Nome=' : encodeURIComponent(jogo.Nome),
        'Produtora=' : encodeURIComponent(jogo.Produtora),
        'Preco=' : encodeURIComponent(jogo.Preco)
    });



}



function clicPost() {
    window.alert("teste");
}
*/
