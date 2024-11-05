
// Seleciona todos os itens de navegação
const navLinks = document.querySelectorAll('.navbar-nav .custom-link');

// Obtém o caminho do URL atual
const currentPath = window.location.pathname;

// Adiciona a classe 'active' ao link que corresponde ao caminho atual e remove dos demais
navLinks.forEach(link => {
    if (link.getAttribute('href') === currentPath) {
        link.classList.add('active');
    } else {
        link.classList.remove('active');
    }
});
