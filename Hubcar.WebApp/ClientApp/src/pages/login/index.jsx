import React, { useEffect, useState } from 'react';
import './styles.css';
import FormLogin from './components/login';
import Register from './components/register';
import { Card, Col, Row } from 'reactstrap';
import image from './../../assets/apr.png';

const Login = () => {
  const [ register, setRegister] = useState(0);

  function handleChangeRegister(){
    setRegister(register + 1);
  }

  return(
    <div>
      <div id="page-home">
        <div className="login">
          <Row style={{paddingTop: "80px"}}>
            <Col style={{marginLeft: "150px"}} sm="5">
              <img src={image} style={{height: "500px", width: "auto"}} />
            </Col>
            <Col sm="5">
              <Card className="card" style={{float: "left"}}>
                {
                  register % 2 === 0?
                  <FormLogin/>
                  :
                  <Register/>
                }
                <a style={{marginTop: 15}} className="link" onClick={handleChangeRegister}>
                  {register % 2 !== 0? "Login" : "Cadastre-se"}
                </a>
              </Card>
            </Col>
          </Row>
        </div>
      </div>
    </div>
  );
} 

export default Login;
