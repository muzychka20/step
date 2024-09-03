import React, { useState } from "react";
import { FileUploader } from "react-drag-drop-files";
import axios from "axios";

const fileTypes = ["JPG", "JPEG", "PNG"];

function DragDrop({ onFileUpload }) { // Accept a callback from CarAdd
  const [file, setFile] = useState(null);

  const handleChange = (file) => {
    setFile(file);
    uploadFile(file);
  };

  const uploadFile = async (file) => {
    const formData = new FormData();
    formData.append("file", file);

    try {
      const response = await axios.post("http://localhost:5175/upload", formData, {
        headers: {
          "Content-Type": "multipart/form-data",
        },
      });
      const filePath = response.data.filePath;
      onFileUpload(filePath); // Pass the file path to CarAdd
    } catch (error) {
      console.error("There was an error uploading the file!", error);
    }
  };

  return (
    <div>      
      <FileUploader handleChange={handleChange} name="file" types={fileTypes} />
      {file && <p>File Selected: {file.name}</p>}
    </div>
  );
}

export default DragDrop;
