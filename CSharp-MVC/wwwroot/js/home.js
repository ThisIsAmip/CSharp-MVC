const nextIcon =
  '<img src="img/svg/right-arrow.svg" alt:="right" style="width: 1.5rem;">';
const prevIcon =
  '<img src="img/svg/left-arrow.svg" alt:="left" style="width: 1.5rem;">';
$(".cate").owlCarousel({
  loop: true,
  margin: 0,
  dots: false,
  autoplay: false,
  autoplayTimeout: 3000,
  autoplayHoverPause: true,
  responsive: {
    0: {
      items: 1,
    },
    600: {
      items: 3,
    },
    1000: {
      items: 5,
    },
  },
});
$(".prod").owlCarousel({
  autoplay: true,
  autoplayTimeout: 3000,
  autoplayHoverPause: true,
  loop: true,
  margin: 30,
  nav: true,
  navText: [prevIcon, nextIcon],
  dots: false,
  responsive: {
    0: {
      items: 1,
    },
    400: {
      items: 2,
    },
    600: {
      items: 3,
    },
    1000: {
      items: 4,
    },
    1300: {
      items: 5,
    },
  },
});
$(".new").owlCarousel({
  loop: false,
  margin: 20,
  dots: false,
  nav: true,
  responsive: {
    0: {
      items: 1,
    },
    600: {
      items: 2,
    },
    1000: {
      items: 4,
    },
  },
});
$(".sprod").owlCarousel({
  autoplay: true,
  autoplayTimeout: 3000,
  autoplayHoverPause: true,
  loop: true,
  margin: 10,
  nav: true,
  navText: [prevIcon, nextIcon],
  dots: false,
  responsive: {
    0: {
      items: 1,
    },
    600: {
      items: 2,
    },
    1000: {
      items: 3,
    },
  },
});
$(".brand").owlCarousel({
  autoplay: true,
  autoplayTimeout: 1000,
  autoplayHoverPause: true,
  loop: true,
  margin: 70,
  nav: false,
  dots: false,
  responsive: {
    0: {
      items: 2,
    },
    600: {
      items: 4,
    },
    1000: {
      items: 7,
    },
  },
});
