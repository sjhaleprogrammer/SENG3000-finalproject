const wrapper = document.querySelector('.wrapper');
const signuplink = document.querySelector('.signup-link');
const loginlink = document.querySelector('.login-link');
const btnpopup = document.querySelector('.btn.white-btn');
const iconclose = document.querySelector('.icon-close');      

signuplink.onclick = () => {
  wrapper.classList.add('active');
};

loginlink.onclick= () => {
  wrapper.classList.remove('active');
};

btnpopup.onclick= () => {
  wrapper.classList.add('active-popup');
};

iconclose.onclick= () => {
  wrapper.classList.remove('active-popup');
  wrapper.classList.remove('active');
};


function MyMenuFunction() {
  var x = document.getElementById("navMenu");
  if(x.className === "nav-menu") {
    x.className += " responsive";
  } else {
    x.className = "nav-menu";
  }

}
