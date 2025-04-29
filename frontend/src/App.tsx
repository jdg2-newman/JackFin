import { Outlet } from 'react-router';
import './App.css';
import NavBar from './Components/Navbar/Navbar';

function App() {
  return (
    <>
    <NavBar />
    <Outlet />
    </>
  );
}

export default App;
