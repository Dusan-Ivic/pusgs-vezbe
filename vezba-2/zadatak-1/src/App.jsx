import "./App.css";
import { Route, Routes } from "react-router-dom";
import LogoList from "./components/LogoList/LogoList";
import LogoItem from "./components/LogoItem/LogoItem";

function App() {
  return (
    <div className="App">
      <Routes>
        <Route path="/logos">
          <Route index element={<LogoList />} />
          <Route path=":name" element={<LogoItem />} />
        </Route>
      </Routes>
    </div>
  );
}

export default App;
