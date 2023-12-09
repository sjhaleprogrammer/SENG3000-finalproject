function login() {
  // Get email and password values
  var email = document.getElementById('email').value;
  var password = document.getElementById('password').value;

  // You should perform additional validation and sanitation here

  // Create a JSON object
  var jsonData = {
    email: email,
    password: password
  };


 
 
  // Make a Fetch API request
  fetch('http://localhost:5013/api/token/authenticate', {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(jsonData),
  })
  .then(response => {
    if (!response.ok) {
      // Check for forbidden status (403) or other errors
      if (response.status === 403) {
        console.error('Forbidden: Access Denied');
      } else {
        console.error('Error:', response.statusText);
      }
      throw new Error('Network response was not ok');
    }
    return response.text();
  })
  .then(data => {
    // Check the content for successful or unsuccessful login
    if (data.toLowerCase() === 'success') {
      document.getElementById('result').innerHTML = 'Login successful';
    } else {
      document.getElementById('result').innerHTML = 'Incorrect login';
    }
  })
  .catch(error => {
    console.error('Fetch Error:', error);
    document.getElementById('result').innerHTML = 'Error during login';
  });

}
