window.rangeFilter = {
  init: function () {
    let range = document.querySelectorAll("[data-type-range]");
    let currentValue = 5000;
    range.forEach((item) => {
      let parent = item.parentElement;
      let getRangeValue = parent.parentElement;
      let rangeValue = getRangeValue.querySelectorAll("[get-set-number-velue]");
      let rangeSlider = parent.querySelectorAll("[data-type-range]");
      let buttons = parent.querySelectorAll("[data-type-circle]");
      let line = parent.querySelector("[data-type-line]");
      rangeSlider[0].oninput = function () {
        let rangeWidthMax =
          (item.offsetWidth - buttons[0].offsetWidth) /
          (parseInt(rangeSlider[0].max) - parseInt(rangeSlider[0].min));
        let pxValueMax =
          (parseInt(rangeSlider[0].value) - parseInt(rangeSlider[0].min)) *
            rangeWidthMax -
          buttons[0].offsetWidth / 100;
        if (
          parseInt(rangeSlider[1].value) - parseInt(rangeSlider[0].value) <=
          currentValue
        ) {
          rangeSlider[0].value = parseInt(rangeSlider[1].value) - currentValue;
        } else {
          buttons[0].style.left = pxValueMax + "px";
          line.style.left = pxValueMax + "px";
        }
        rangeValue[0].value = parseInt(rangeSlider[0].value);
        rangeValue[0].innerHTML = rangeValue[0].value;
      };
      rangeSlider[1].oninput = function () {
        let rangeWidthMin =
          (item.offsetWidth - buttons[1].offsetWidth) /
          (parseInt(rangeSlider[1].min) - parseInt(rangeSlider[1].max));
        let pxValueMin =
          (parseInt(rangeSlider[1].value) - parseInt(rangeSlider[1].max)) *
            rangeWidthMin -
          buttons[1].offsetWidth / 100;
        if (
          parseInt(rangeSlider[1].value) - parseInt(rangeSlider[0].value) <=
          currentValue
        ) {
          rangeSlider[1].value = parseInt(rangeSlider[0].value) + currentValue;
        } else {
          buttons[1].style.right = pxValueMin + "px";
          line.style.right = pxValueMin + "px";
        }
        rangeValue[1].value = parseInt(rangeSlider[1].value);
        rangeValue[1].innerHTML = rangeValue[1].value;
      };
    });
  },
};
