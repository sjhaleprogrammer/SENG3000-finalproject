
/*// Set up the scene
var scene = new THREE.Scene();
var camera = new THREE.PerspectiveCamera(75, window.innerWidth / window.innerHeight, 0.1, 1000);

// Adjust the renderer size to cover the entire viewport
var renderer = new THREE.WebGLRenderer();
renderer.setSize(window.innerWidth, window.innerHeight);
document.body.appendChild(renderer.domElement);

// Create a textured sphere
var textureLoader = new THREE.TextureLoader();
var texture = textureLoader.load('images/texture.jpg');
var geometry = new THREE.SphereGeometry(3, 64, 64);
var material = new THREE.MeshStandardMaterial({
  map: texture,
});
var sphere = new THREE.Mesh(geometry, material);
scene.add(sphere);

// Position the camera
camera.position.z = 5;

// Add HemisphereLight for ambient lighting
var hemisphereLight = new THREE.HemisphereLight(0xffffff, 0x404040, 1);
scene.add(hemisphereLight);

// Add PointLight to simulate the sun
var sunLight = new THREE.PointLight(0xffffff, 1);
sunLight.position.set(5, 5, 5);
scene.add(sunLight);

// Create background stars
var starsGeometry = new THREE.BufferGeometry();
var starsMaterial = new THREE.PointsMaterial({ color: 0xFFFFFF, size: 0.05 });

var starsVertices = [];
for (let i = 0; i < 1000; i++) {
  const x = (Math.random() - 0.5) * 2000;
  const y = (Math.random() - 0.5) * 2000;
  const z = (Math.random() - 0.5) * 2000;
  starsVertices.push(x, y, z);
}

starsGeometry.setAttribute('position', new THREE.Float32BufferAttribute(starsVertices, 3));
var stars = new THREE.Points(starsGeometry, starsMaterial);
scene.add(stars);

// Render the scene
var animate = function () {
  requestAnimationFrame(animate);

  // Rotate the sphere
  sphere.rotation.y += 0.005;

  renderer.render(scene, camera);
};

animate();    

// Resize event listener
window.addEventListener('resize', function () {
  // Update the camera aspect ratio and renderer size on window resize
  camera.aspect = window.innerWidth / window.innerHeight;
  camera.updateProjectionMatrix();
  renderer.setSize(window.innerWidth, window.innerHeight);
}, false);

*/