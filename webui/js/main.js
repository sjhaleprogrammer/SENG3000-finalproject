// Add an "active" class to the current tab
var navbar = document.getElementsByClassName("navbar")[0];
var navItems = navbar.getElementsByClassName("nav-item");

for (var i = 0; i < navItems.length; i++) {
  navItems[i].addEventListener("click", function() {
    var current = document.getElementsByClassName("active");
    if (current.length > 0) {
      current[0].className = current[0].className.replace(" active", "");
    }
    this.className += " active";
  });
}



var interactiveBox = document.getElementById("interactive-box");
var boxText = document.getElementById("box-text");

interactiveBox.addEventListener("click", function() {
  boxText.textContent = "Clicked!";
  interactiveBox.style.backgroundColor = "#e74c3c";
});

interactiveBox.addEventListener("mouseout", function() {
  boxText.textContent = "Click me!";
  interactiveBox.style.backgroundColor = "#3498db";
});