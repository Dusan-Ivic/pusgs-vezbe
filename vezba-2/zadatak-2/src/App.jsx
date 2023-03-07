import "./App.css";
import { Route, Routes } from "react-router-dom";
import AddStudent from "./components/AddStudent/AddStudent";
import Student from "./components/Student/Student";

function App() {
  return (
    <div className="App">
      <Routes>
        <Route path="/student">
          <Route path="new" element={<AddStudent />} />
          <Route path="success/:index" element={<Student />} />
        </Route>
      </Routes>
    </div>
  );
}

export default App;
