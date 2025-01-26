// Функция для фильтрации
function filterProducts(order) {
  const container = document.getElementById("productsContainer");
  const items = Array.from(container.getElementsByClassName("product-item"));

  items.sort((a, b) => {
    const priceA = parseInt(
      a.querySelector(".card-text").textContent.replace("$", "")
    );
    const priceB = parseInt(
      b.querySelector(".card-text").textContent.replace("$", "")
    );

    return order === "asc" ? priceA - priceB : priceB - priceA;
  });

  container.innerHTML = "";
  items.forEach((item) => container.appendChild(item));
}

// Функция для поиска
function searchProducts() {
  const input = document.getElementById("searchInput").value.toLowerCase();
  const items = document.querySelectorAll(".product-item");

  items.forEach((item) => {
    const name = item.querySelector(".card-title").textContent.toLowerCase();
    item.style.display = name.includes(input) ? "block" : "none";
  });
}
