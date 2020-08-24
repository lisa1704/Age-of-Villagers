//
//  ViewController.swift
//  AgeOfVillagers
//
//  Created by Md Ariful Islam on 24/8/20.
//  Copyright © 2020 Md Ariful Islam. All rights reserved.
//

import Cocoa

class ViewController: NSViewController {
    
    var asset: String = ""
  
    override func viewDidLoad() {
        super.viewDidLoad()

        // Do any additional setup after loading the view.
        
    }

    override var representedObject: Any? {
        didSet {
        // Update the view, if already loaded.
        }
    }

    @IBAction func OnHouseClicked(_ sender: Any) {
        print("house Selected")
        asset = "House"
    }
    @IBAction func OnWaterClicked(_ sender: Any) {
        print("Water Selected")
        asset = "Water"
    }
    @IBAction func OnTreeClicked(_ sender: Any) {
        print("Tree Selected")
        asset = "Tree"
    }
    
    
    @IBAction func getPoint(_ sender: Any) {
        
        
        let currentMouseLocation = NSEvent.mouseLocation
        let xPosition = currentMouseLocation.x
        let yPosition = currentMouseLocation.y
        print("point touch")
        print(xPosition)
        print(yPosition)
        
        let label = NSTextField(frame: NSMakeRect(0,0,100,50))
        label.frame = CGRect(origin:CGPoint(x: Int(xPosition), y: Int(yPosition)), size: CGSize(width: label.bounds.width, height: label.bounds.height))
        label.stringValue = asset
        label.isEditable = false
        self.view.addSubview(label)
    }
}

