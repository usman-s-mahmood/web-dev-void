// document.getElementById('footer-year').innerHTML = new Date().getFullYear();

// Navbar Responsiveness
document.getElementById('toggle-btn').addEventListener('click', () => {
    const menu = document.getElementById('menu');
    menu.classList.toggle('active'); // Toggle the active class
});

// Hero Slider
let currentSlide = 0;

const slides = document.querySelectorAll('.slide');
const totalSlides = slides.length;

document.getElementById('nextBtn').addEventListener('click', () => {
    currentSlide = (currentSlide + 1) % totalSlides; // Cycle to next slide
    updateSlider();
});

document.getElementById('prevBtn').addEventListener('click', () => {
    currentSlide = (currentSlide - 1 + totalSlides) % totalSlides; // Cycle to previous slide
    updateSlider();
});

function updateSlider() {
    const slidesContainer = document.querySelector('.slides');
    
    // Move the slides container to show the current slide
    slidesContainer.style.transform = `translateX(-${currentSlide * 100}%)`;
    
    // Optionally, you can add active classes or other effects here
}