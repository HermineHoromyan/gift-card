window.swiperConfig = {
  init: function () {
    let bannerSlider = new Swiper("[banner-slider]", {
      slidesPerView: 1,
      spaceBetween: 16,
      paginationClickable: true,
      autoplay: {
        delay: 2000,
      },
      pagination: {
        el: ".swiper-pagination",
        clickable: true,
      },
    });

    let productSlider = new Swiper("[product-slider]", {
      slidesPerView: 1,
      spaceBetween: 16,
      navigation: {
        nextEl: ".swiper-next",
        prevEl: ".swiper-prev",
      },
      breakpoints: {
        520: {
          slidesPerView: 2,
        },
        768: {
          slidesPerView: 3,
        },
        1024: {
          slidesPerView: 5,
          spaceBetween: 32,
        },
      },
    });

    let newCategory = new Swiper("[category-slider]", {
      slidesPerView: 2,
      spaceBetween: 16,
      breakpoints: {
        768: {
          slidesPerView: 3,
        },
        1024: {
          slidesPerView: 4,
          spaceBetween: 32,
        },
      },
      pagination: {
        el: ".swiper-pagination",
        clickable: true,
      },
    });
  },
};
