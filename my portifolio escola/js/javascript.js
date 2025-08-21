
let botao = document.getElementById('botao')
let body = document.querySelector('body')

botao.addEventListener('click', ()=>{
    botao.classList.toggle('dark')
    body.classList.toggle('dark')
})