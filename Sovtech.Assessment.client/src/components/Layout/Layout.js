import React from 'react';
import { Container, Row } from 'react-bootstrap';
import Navigation from '../Navigation/Navigation';

const style = {
backgroundImage: 'url("/background.jpg")',
  backgroundPosition: 'center',
  backgroundSize: 'cover',
  backgroundRepeat: 'no-repeat',
  width: '100vw',
  height: '100vh',
}

const layout = (props) => {
    return (
        
        <div style={style}>
        <Container>
            <Row>
                <Navigation/>
            </Row>
            <main>
                {props.children}
            </main>
            </Container>
            </div>
    )
}

export default layout;