import React, { useState } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavItem, NavLink, Modal, ModalHeader, ModalBody, ModalFooter, Button } from 'reactstrap';
import { Link } from 'react-router-dom';
import Logo from './../../assets/logoHigh.png';
import { BsFillPlusSquareFill, BsFillPersonFill } from 'react-icons/bs';
import './NavMenu.css';
import CreateCarro from './../../pages/carro/create';

export const NavMenu = () => {
  let [modal, setModal] = useState(false);

  function toggleModal(){
    setModal(!modal);
  }

  return (
    <header>
      <Navbar className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3" light>
        <Container>
          <NavbarBrand tag={Link} to="/"><img src={Logo} className="logo"/></NavbarBrand>
          <Collapse className="d-sm-inline-flex flex-sm-row-reverse" navbar>
            <ul className="navbar-nav flex-grow">
              <NavItem>
                <NavLink tag={Link} className="icon" to="/perfil"><BsFillPersonFill/></NavLink>
              </NavItem>
              <NavItem>
                <NavLink tag={Link} className="icon" onClick={toggleModal}><BsFillPlusSquareFill/></NavLink>
              </NavItem>
            </ul>
          </Collapse>
        </Container>
      </Navbar>
      <div>
        <CreateCarro modal={modal} toggle={toggleModal}/>
      </div>
    </header>
  );
}

export default NavMenu;
