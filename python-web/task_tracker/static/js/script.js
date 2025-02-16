BASE_URL = "http://127.0.0.1:5000";

function deleteTask(task_id) {
  $.ajax({
    url: BASE_URL + "/delete-task",
    type: "POST",
    contentType: "application/json",
    data: JSON.stringify({ task_id: task_id }),
    success: function (data) {    
      Toastify({
        text: data.message,
        className: "info",
        style: {
          background: "linear-gradient(to right, #00b09b, #96c93d)",
        },
      }).showToast();
      setTimeout(() => location.reload(), 500);
    },
    error: function (error) {
      Toastify({
        text: error.responseText,
        className: "info",
        style: {
          background: "linear-gradient(to right, #00b09b, #96c93d)",
        },
      }).showToast();
    },
  });
}

function editTask(id) {
    window.location = `/create_update_task/${id}`
}
 