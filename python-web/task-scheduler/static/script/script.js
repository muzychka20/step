function deleteItem(id) {
  axios
    .post(`/delete/${id}`)
    .then((response) => {
      console.log(response);
      window.location.href = response.request.responseURL;
    })
    .catch((error) => console.error("Error:", error));
}
function editItem(id) {
  // hide manage buttons
  let deleteBtn = document.getElementById("delete-task-btn-" + id);
  let editBtn = document.getElementById("edit-task-btn-" + id);
  let saveBtn = document.getElementById("save-task-btn-" + id);
  deleteBtn.style.display = "none";
  editBtn.style.display = "none";
  saveBtn.style.display = "block";

  // hide the current text, saving its value
  let taskElement = document.getElementById(id);
  taskElement.querySelector(".task-text").style.display = "none";
  let text = taskElement.querySelector(".task-text").innerText;

  // create input wwith current text
  let input = document.createElement("input");
  input.type = "text";
  input.value = text;
  input.id = "new-text-" + id;
  input.className = "new-text-input";
  input.required = true;

  taskElement.appendChild(input);
}

function saveItem(id) {
  let input = document.getElementById("new-text-" + id);
  let new_text = input.value;
  if (new_text) {
    axios
      .post(`/update/${id}`, { new_text: new_text })
      .then((response) => {
        console.log(response);
        window.location.href = response.request.responseURL;
      })
      .catch((error) => console.error("Error:", error));
  } else {
    alert("Enter the value!");
  }
}
